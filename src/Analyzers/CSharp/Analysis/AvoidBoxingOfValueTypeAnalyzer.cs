﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Roslynator.CSharp.Analysis
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class AvoidBoxingOfValueTypeAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get { return ImmutableArray.Create(DiagnosticDescriptors.AvoidBoxingOfValueType); }
        }

        public override void Initialize(AnalysisContext context)
        {
            base.Initialize(context);

            context.RegisterSyntaxNodeAction(AnalyzeAddExpression, SyntaxKind.AddExpression);
            context.RegisterSyntaxNodeAction(AnalyzeInterpolation, SyntaxKind.Interpolation);
        }

        private static void AnalyzeAddExpression(SyntaxNodeAnalysisContext context)
        {
            var addExpression = (BinaryExpressionSyntax)context.Node;

            if (addExpression.ContainsDiagnostics)
                return;

            IMethodSymbol methodSymbol = context.SemanticModel.GetMethodSymbol(addExpression, context.CancellationToken);

            if (!SymbolUtility.IsStringAdditionOperator(methodSymbol))
                return;

            ExpressionSyntax expression = GetObjectExpression()?.WalkDownParentheses();

            if (expression == null)
                return;

            if (expression.Kind() == SyntaxKind.AddExpression)
                return;

            ITypeSymbol typeSymbol = context.SemanticModel.GetTypeSymbol(expression, context.CancellationToken);

            if (typeSymbol?.IsValueType != true)
                return;

            DiagnosticHelpers.ReportDiagnostic(context, DiagnosticDescriptors.AvoidBoxingOfValueType, expression);

            ExpressionSyntax GetObjectExpression()
            {
                ImmutableArray<IParameterSymbol> parameters = methodSymbol.Parameters;

                if (parameters[0].Type.SpecialType == SpecialType.System_Object)
                {
                    return addExpression.Left;
                }
                else if (parameters[1].Type.SpecialType == SpecialType.System_Object)
                {
                    return addExpression.Right;
                }
                else
                {
                    return null;
                }
            }
        }

        private static void AnalyzeInterpolation(SyntaxNodeAnalysisContext context)
        {
            var interpolation = (InterpolationSyntax)context.Node;

            if (interpolation.ContainsDiagnostics)
                return;

            if (interpolation.AlignmentClause != null)
                return;

            if (interpolation.FormatClause != null)
                return;

            ExpressionSyntax expression = interpolation.Expression?.WalkDownParentheses();

            if (expression == null)
                return;

            ITypeSymbol typeSymbol = context.SemanticModel.GetTypeSymbol(expression, context.CancellationToken);

            if (typeSymbol?.IsValueType != true)
                return;

            DiagnosticHelpers.ReportDiagnostic(context, DiagnosticDescriptors.AvoidBoxingOfValueType, expression);
        }
    }
}
