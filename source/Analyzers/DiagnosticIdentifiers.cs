﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.CSharp
{
    public static class DiagnosticIdentifiers
    {
        public const string Prefix = "RCS";

        public const string AddBraces = Prefix + "1001";
        public const string RemoveBraces = Prefix + "1002";
        public const string AddBracesToIfElse = Prefix + "1003";
        public const string RemoveBracesFromIfElse = Prefix + "1004";
        public const string SimplifyNestedUsingStatement = Prefix + "1005";
        public const string MergeElseClauseWithNestedIfStatement = Prefix + "1006";
        public const string AvoidEmbeddedStatement = Prefix + "1007";
        public const string UseExplicitTypeInsteadOfVar = Prefix + "1008";
        public const string UseExplicitTypeInsteadOfVarInForEach = Prefix + "1009";
        public const string UseVarInsteadOfExplicitType = Prefix + "1010";
        //public const string UseVarInsteadOfExplicitTypeInForEach = Prefix + "1011";
        public const string UseExplicitTypeInsteadOfVarEvenIfObvious = Prefix + "1012";
        public const string UsePredefinedType = Prefix + "1013";
        public const string AvoidImplicitlyTypedArray = Prefix + "1014";
        public const string UseNameOfOperator = Prefix + "1015";
        public const string UseExpressionBodiedMember = Prefix + "1016";
        public const string AvoidMultilineExpressionBody = Prefix + "1017";
        public const string AddDefaultAccessModifier = Prefix + "1018";
        public const string ReorderModifiers = Prefix + "1019";
        public const string SimplifyNullableOfT = Prefix + "1020";
        public const string SimplifyLambdaExpression = Prefix + "1021";
        public const string SimplifyLambdaExpressionParameterList = Prefix + "1022";
        public const string FormatEmptyBlock = Prefix + "1023";
        public const string FormatAccessorList = Prefix + "1024";
        public const string FormatEachEnumMemberOnSeparateLine = Prefix + "1025";
        public const string FormatEachStatementOnSeparateLine = Prefix + "1026";
        public const string FormatEmbeddedStatementOnSeparateLine = Prefix + "1027";
        public const string FormatSwitchSectionStatementOnSeparateLine = Prefix + "1028";
        public const string FormatBinaryOperatorOnNextLine = Prefix + "1029";
        public const string AddEmptyLineAfterEmbeddedStatement = Prefix + "1030";
        public const string RemoveRedundantBraces = Prefix + "1031";
        public const string RemoveRedundantParentheses = Prefix + "1032";
        public const string RemoveRedundantBooleanLiteral = Prefix + "1033";
        public const string RemoveRedundantSealedModifier = Prefix + "1034";
        public const string RemoveRedundantCommaInInitializer = Prefix + "1035";
        public const string RemoveRedundantEmptyLine = Prefix + "1036";
        public const string RemoveTrailingWhitespace = Prefix + "1037";
        public const string RemoveEmptyStatement = Prefix + "1038";
        public const string RemoveEmptyAttributeArgumentList = Prefix + "1039";
        public const string RemoveEmptyElseClause = Prefix + "1040";
        public const string RemoveEmptyInitializer = Prefix + "1041";
        public const string RemoveEnumDefaultUnderlyingType = Prefix + "1042";
        public const string RemovePartialModifierFromTypeWithSinglePart = Prefix + "1043";
        public const string RemoveOriginalExceptionFromThrowStatement = Prefix + "1044";
        public const string RenamePrivateFieldAccordingToCamelCaseWithUnderscore = Prefix + "1045";
        public const string AsynchronousMethodNameShouldEndWithAsync = Prefix + "1046";
        public const string NonAsynchronousMethodNameShouldNotEndWithAsync = Prefix + "1047";
        public const string ReplaceAnonymousMethodWithLambdaExpression = Prefix + "1048";
        public const string SimplifyBooleanComparison = Prefix + "1049";
        public const string AddConstructorArgumentList = Prefix + "1050";
        public const string ParenthesizeConditionInConditionalExpression = Prefix + "1051";
        public const string DeclareEachAttributeSeparately = Prefix + "1052";
        //public const string ReplaceForEachWithFor = Prefix + "1053";
        public const string MergeLocalDeclarationWithReturnStatement = Prefix + "1054";
        public const string AvoidSemicolonAtEndOfDeclaration = Prefix + "1055";
        public const string AvoidUsageOfUsingAliasDirective = Prefix + "1056";
        public const string AddEmptyLineBetweenDeclarations = Prefix + "1057";
        public const string UseCompoundAssignment = Prefix + "1058";
        public const string AvoidLockingOnPubliclyAccessibleInstance = Prefix + "1059";
        public const string DeclareEachTypeInSeparateFile = Prefix + "1060";
        public const string MergeIfStatementWithNestedIfStatement = Prefix + "1061";
        public const string AvoidInterpolatedStringWithNoInterpolation = Prefix + "1062";
        public const string AvoidUsageOfDoStatementToCreateInfiniteLoop = Prefix + "1063";
        public const string AvoidUsageOfForStatementToCreateInfiniteLoop = Prefix + "1064";
        public const string AvoidUsageOfWhileStatementToCreateInfiniteLoop = Prefix + "1065";
        public const string RemoveEmptyFinallyClause = Prefix + "1066";
        public const string RemoveEmptyArgumentList = Prefix + "1067";
        public const string SimplifyLogicalNotExpression = Prefix + "1068";
        public const string RemoveUnnecessaryCaseLabel = Prefix + "1069";
        public const string RemoveRedundantDefaultSwitchSection = Prefix + "1070";
        public const string RemoveRedundantBaseConstructorCall = Prefix + "1071";
        public const string RemoveEmptyNamespaceDeclaration = Prefix + "1072";
        public const string ReplaceIfStatementWithReturnStatement = Prefix + "1073";
        public const string RemoveRedundantConstructor = Prefix + "1074";
        public const string AvoidEmptyCatchClauseThatCatchesSystemException = Prefix + "1075";
        public const string FormatDeclarationBraces = Prefix + "1076";
        public const string SimplifyLinqMethodChain = Prefix + "1077";
        public const string ReplaceStringEmptyWithEmptyStringLiteral = Prefix + "1078";
        public const string ThrowingOfNewNotImplementedException = Prefix + "1079";
        public const string ReplaceAnyMethodWithCountOrLengthProperty = Prefix + "1080";
        public const string SplitVariableDeclaration = Prefix + "1081";
        public const string ReplaceCountMethodWithCountOrLengthProperty = Prefix + "1082";
        public const string ReplaceCountMethodWithAnyMethod = Prefix + "1083";
        public const string ReplaceConditionalExpressionWithCoalesceExpression = Prefix + "1084";
        public const string ReplacePropertyWithAutoImplementedProperty = Prefix + "1085";
        public const string UseLinefeedAsNewLine = Prefix + "1086";
        public const string UseCarriageReturnAndLinefeedAsNewLine = Prefix + "1087";
        public const string AvoidUsageOfTab = Prefix + "1088";
        public const string UsePostfixUnaryOperatorInsteadOfAssignment = Prefix + "1089";
        public const string CallConfigureAwait = Prefix + "1090";
        public const string RemoveEmptyRegion = Prefix + "1091";
        public const string AddEmptyLineAfterLastStatementInDoStatement = Prefix + "1092";
        public const string RemoveFileWithNoCode = Prefix + "1093";
        public const string DeclareUsingDirectiveOnTopLevel = Prefix + "1094";
        public const string UseCSharp6DictionaryInitializer = Prefix + "1095";
        public const string UseBitwiseOperationInsteadOfHasFlagMethod = Prefix + "1096";
        public const string RemoveRedundantToStringCall = Prefix + "1097";
        public const string AvoidNullLiteralExpressionOnLeftSideOfBinaryExpression = Prefix  + "1098";
        public const string DefaultLabelShouldBeLastLabelInSwitchSection = Prefix + "1099";
        public const string FormatDocumentationSummaryOnSingleLine = Prefix + "1100";
        public const string FormatDocumentationSummaryOnMultipleLines = Prefix + "1101";
        public const string MarkClassAsStatic = Prefix + "1102";
        public const string ReplaceIfStatementWithAssignment = Prefix + "1103";
        public const string SimplifyConditionalExpression = Prefix + "1104";
        public const string MergeInterpolationIntoInterpolatedString = Prefix + "1105";
        public const string RemoveEmptyDestructor = Prefix + "1106";
        public const string RemoveRedundantStringToCharArrayCall = Prefix + "1107";
        public const string AddStaticModifierToAllPartialClassDeclarations = Prefix + "1108";
        public const string UseCastMethodInsteadOfSelectMethod = Prefix + "1109";
        public const string DeclareTypeInsideNamespace = Prefix + "1110";
        public const string AddBracesToSwitchSectionWithMultipleStatements = Prefix + "1111";
        public const string CombineEnumerableWhereMethodChain = Prefix + "1112";
        public const string UseStringIsNullOrEmptyMethod = Prefix + "1113";
        public const string RemoveRedundantDelegateCreation = Prefix + "1114";
        public const string ReplaceReturnStatementWithExpressionStatement = Prefix + "1115";
        public const string AddBreakStatementToSwitchSection = Prefix + "1116";
        public const string AddReturnStatementThatReturnsDefaultValue = Prefix + "1117";
        public const string MarkLocalVariableAsConst = Prefix + "1118";
        public const string CallFindMethodInsteadOfFirstOrDefaultMethod = Prefix + "1119";
        public const string UseElementAccessInsteadOfElementAt = Prefix + "1120";
        public const string UseElementAccessInsteadOfFirst = Prefix + "1121";
        public const string AddMissingSemicolon = Prefix + "1122";
        public const string AddParenthesesAccordingToOperatorPrecedence = Prefix + "1123";
        public const string InlineLocalVariable = Prefix + "1124";
        public const string MarkMemberAsStatic = Prefix + "1125";
        public const string AvoidEmbeddedStatementInIfElse = Prefix + "1126";
        public const string MergeLocalDeclarationWithInitialization = Prefix + "1127";
        public const string UseCoalesceExpression = Prefix + "1128";
    }
}
