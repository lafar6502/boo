using System;

namespace Boo.Ast
{
	public class DepthFirstSwitcher : IAstSwitcher
	{
		public bool Switch(Boo.Util.ISwitchable switchable)
		{
			if (null != switchable)
			{			
				switchable.Switch(this);
				return true;
			}
			return false;
		}
		
		public virtual void OnCompileUnit(CompileUnit node)
		{			
			if (EnterCompileUnit(node))
			{		
				Switch(node.Modules);
			}
			LeaveCompileUnit(node);
		}
		
		public virtual bool EnterCompileUnit(CompileUnit node)
		{
			return true;
		}
		
		public virtual void LeaveCompileUnit(CompileUnit node)
		{
		}
		
		public virtual void OnTypeReference(TypeReference node)
		{			
		}
		
		public virtual void OnPackage(Package node)
		{			
		}
		
		public virtual void OnUsing(Using node)
		{			
			if (EnterUsing(node))
			{		
				Switch(node.AssemblyReference);
				Switch(node.Alias);
			}
			LeaveUsing(node);
		}
		
		public virtual bool EnterUsing(Using node)
		{
			return true;
		}
		
		public virtual void LeaveUsing(Using node)
		{
		}
		
		public virtual void OnModule(Module node)
		{			
			if (EnterModule(node))
			{		
				Switch(node.Package);
				Switch(node.Using);
				Switch(node.Globals);
				Switch(node.Attributes);
				Switch(node.Members);
				Switch(node.BaseTypes);
			}
			LeaveModule(node);
		}
		
		public virtual bool EnterModule(Module node)
		{
			return true;
		}
		
		public virtual void LeaveModule(Module node)
		{
		}
		
		public virtual void OnClassDefinition(ClassDefinition node)
		{			
			if (EnterClassDefinition(node))
			{		
				Switch(node.Attributes);
				Switch(node.Members);
				Switch(node.BaseTypes);
			}
			LeaveClassDefinition(node);
		}
		
		public virtual bool EnterClassDefinition(ClassDefinition node)
		{
			return true;
		}
		
		public virtual void LeaveClassDefinition(ClassDefinition node)
		{
		}
		
		public virtual void OnInterfaceDefinition(InterfaceDefinition node)
		{			
			if (EnterInterfaceDefinition(node))
			{		
				Switch(node.Attributes);
				Switch(node.Members);
				Switch(node.BaseTypes);
			}
			LeaveInterfaceDefinition(node);
		}
		
		public virtual bool EnterInterfaceDefinition(InterfaceDefinition node)
		{
			return true;
		}
		
		public virtual void LeaveInterfaceDefinition(InterfaceDefinition node)
		{
		}
		
		public virtual void OnEnumDefinition(EnumDefinition node)
		{			
			if (EnterEnumDefinition(node))
			{		
				Switch(node.Attributes);
				Switch(node.Members);
				Switch(node.BaseTypes);
			}
			LeaveEnumDefinition(node);
		}
		
		public virtual bool EnterEnumDefinition(EnumDefinition node)
		{
			return true;
		}
		
		public virtual void LeaveEnumDefinition(EnumDefinition node)
		{
		}
		
		public virtual void OnEnumMember(EnumMember node)
		{			
			if (EnterEnumMember(node))
			{		
				Switch(node.Initializer);
				Switch(node.Attributes);
			}
			LeaveEnumMember(node);
		}
		
		public virtual bool EnterEnumMember(EnumMember node)
		{
			return true;
		}
		
		public virtual void LeaveEnumMember(EnumMember node)
		{
		}
		
		public virtual void OnField(Field node)
		{			
			if (EnterField(node))
			{		
				Switch(node.Type);
				Switch(node.Attributes);
			}
			LeaveField(node);
		}
		
		public virtual bool EnterField(Field node)
		{
			return true;
		}
		
		public virtual void LeaveField(Field node)
		{
		}
		
		public virtual void OnProperty(Property node)
		{			
			if (EnterProperty(node))
			{		
				Switch(node.Getter);
				Switch(node.Setter);
				Switch(node.Type);
				Switch(node.Attributes);
			}
			LeaveProperty(node);
		}
		
		public virtual bool EnterProperty(Property node)
		{
			return true;
		}
		
		public virtual void LeaveProperty(Property node)
		{
		}
		
		public virtual void OnLocal(Local node)
		{			
		}
		
		public virtual void OnMethod(Method node)
		{			
			if (EnterMethod(node))
			{		
				Switch(node.Parameters);
				Switch(node.ReturnType);
				Switch(node.ReturnTypeAttributes);
				Switch(node.Body);
				Switch(node.Locals);
				Switch(node.Attributes);
			}
			LeaveMethod(node);
		}
		
		public virtual bool EnterMethod(Method node)
		{
			return true;
		}
		
		public virtual void LeaveMethod(Method node)
		{
		}
		
		public virtual void OnConstructor(Constructor node)
		{			
			if (EnterConstructor(node))
			{		
				Switch(node.Attributes);
				Switch(node.Parameters);
				Switch(node.ReturnType);
				Switch(node.ReturnTypeAttributes);
				Switch(node.Body);
				Switch(node.Locals);
			}
			LeaveConstructor(node);
		}
		
		public virtual bool EnterConstructor(Constructor node)
		{
			return true;
		}
		
		public virtual void LeaveConstructor(Constructor node)
		{
		}
		
		public virtual void OnParameterDeclaration(ParameterDeclaration node)
		{			
			if (EnterParameterDeclaration(node))
			{		
				Switch(node.Type);
				Switch(node.Attributes);
			}
			LeaveParameterDeclaration(node);
		}
		
		public virtual bool EnterParameterDeclaration(ParameterDeclaration node)
		{
			return true;
		}
		
		public virtual void LeaveParameterDeclaration(ParameterDeclaration node)
		{
		}
		
		public virtual void OnDeclaration(Declaration node)
		{			
			if (EnterDeclaration(node))
			{		
				Switch(node.Type);
			}
			LeaveDeclaration(node);
		}
		
		public virtual bool EnterDeclaration(Declaration node)
		{
			return true;
		}
		
		public virtual void LeaveDeclaration(Declaration node)
		{
		}
		
		public virtual void OnBlock(Block node)
		{			
			if (EnterBlock(node))
			{		
				Switch(node.Statements);
			}
			LeaveBlock(node);
		}
		
		public virtual bool EnterBlock(Block node)
		{
			return true;
		}
		
		public virtual void LeaveBlock(Block node)
		{
		}
		
		public virtual void OnAttribute(Attribute node)
		{			
			if (EnterAttribute(node))
			{		
				Switch(node.Arguments);
				Switch(node.NamedArguments);
			}
			LeaveAttribute(node);
		}
		
		public virtual bool EnterAttribute(Attribute node)
		{
			return true;
		}
		
		public virtual void LeaveAttribute(Attribute node)
		{
		}
		
		public virtual void OnStatementModifier(StatementModifier node)
		{			
			if (EnterStatementModifier(node))
			{		
				Switch(node.Condition);
			}
			LeaveStatementModifier(node);
		}
		
		public virtual bool EnterStatementModifier(StatementModifier node)
		{
			return true;
		}
		
		public virtual void LeaveStatementModifier(StatementModifier node)
		{
		}
		
		public virtual void OnDeclarationStatement(DeclarationStatement node)
		{			
			if (EnterDeclarationStatement(node))
			{		
				Switch(node.Declaration);
				Switch(node.Initializer);
				Switch(node.Modifier);
			}
			LeaveDeclarationStatement(node);
		}
		
		public virtual bool EnterDeclarationStatement(DeclarationStatement node)
		{
			return true;
		}
		
		public virtual void LeaveDeclarationStatement(DeclarationStatement node)
		{
		}
		
		public virtual void OnAssertStatement(AssertStatement node)
		{			
			if (EnterAssertStatement(node))
			{		
				Switch(node.Condition);
				Switch(node.Message);
				Switch(node.Modifier);
			}
			LeaveAssertStatement(node);
		}
		
		public virtual bool EnterAssertStatement(AssertStatement node)
		{
			return true;
		}
		
		public virtual void LeaveAssertStatement(AssertStatement node)
		{
		}
		
		public virtual void OnTryStatement(TryStatement node)
		{			
			if (EnterTryStatement(node))
			{		
				Switch(node.ProtectedBlock);
				Switch(node.ExceptionHandlers);
				Switch(node.SuccessBlock);
				Switch(node.EnsureBlock);
				Switch(node.Modifier);
			}
			LeaveTryStatement(node);
		}
		
		public virtual bool EnterTryStatement(TryStatement node)
		{
			return true;
		}
		
		public virtual void LeaveTryStatement(TryStatement node)
		{
		}
		
		public virtual void OnExceptionHandler(ExceptionHandler node)
		{			
			if (EnterExceptionHandler(node))
			{		
				Switch(node.Declaration);
				Switch(node.Statements);
			}
			LeaveExceptionHandler(node);
		}
		
		public virtual bool EnterExceptionHandler(ExceptionHandler node)
		{
			return true;
		}
		
		public virtual void LeaveExceptionHandler(ExceptionHandler node)
		{
		}
		
		public virtual void OnIfStatement(IfStatement node)
		{			
			if (EnterIfStatement(node))
			{		
				Switch(node.Expression);
				Switch(node.TrueBlock);
				Switch(node.FalseBlock);
				Switch(node.Modifier);
			}
			LeaveIfStatement(node);
		}
		
		public virtual bool EnterIfStatement(IfStatement node)
		{
			return true;
		}
		
		public virtual void LeaveIfStatement(IfStatement node)
		{
		}
		
		public virtual void OnForStatement(ForStatement node)
		{			
			if (EnterForStatement(node))
			{		
				Switch(node.Declarations);
				Switch(node.Iterator);
				Switch(node.Statements);
				Switch(node.Modifier);
			}
			LeaveForStatement(node);
		}
		
		public virtual bool EnterForStatement(ForStatement node)
		{
			return true;
		}
		
		public virtual void LeaveForStatement(ForStatement node)
		{
		}
		
		public virtual void OnWhileStatement(WhileStatement node)
		{			
			if (EnterWhileStatement(node))
			{		
				Switch(node.Condition);
				Switch(node.Statements);
				Switch(node.Modifier);
			}
			LeaveWhileStatement(node);
		}
		
		public virtual bool EnterWhileStatement(WhileStatement node)
		{
			return true;
		}
		
		public virtual void LeaveWhileStatement(WhileStatement node)
		{
		}
		
		public virtual void OnGivenStatement(GivenStatement node)
		{			
			if (EnterGivenStatement(node))
			{		
				Switch(node.Expression);
				Switch(node.WhenClauses);
				Switch(node.OtherwiseBlock);
				Switch(node.Modifier);
			}
			LeaveGivenStatement(node);
		}
		
		public virtual bool EnterGivenStatement(GivenStatement node)
		{
			return true;
		}
		
		public virtual void LeaveGivenStatement(GivenStatement node)
		{
		}
		
		public virtual void OnWhenClause(WhenClause node)
		{			
			if (EnterWhenClause(node))
			{		
				Switch(node.Condition);
				Switch(node.Statements);
			}
			LeaveWhenClause(node);
		}
		
		public virtual bool EnterWhenClause(WhenClause node)
		{
			return true;
		}
		
		public virtual void LeaveWhenClause(WhenClause node)
		{
		}
		
		public virtual void OnBreakStatement(BreakStatement node)
		{			
			if (EnterBreakStatement(node))
			{		
				Switch(node.Modifier);
			}
			LeaveBreakStatement(node);
		}
		
		public virtual bool EnterBreakStatement(BreakStatement node)
		{
			return true;
		}
		
		public virtual void LeaveBreakStatement(BreakStatement node)
		{
		}
		
		public virtual void OnContinueStatement(ContinueStatement node)
		{			
			if (EnterContinueStatement(node))
			{		
				Switch(node.Modifier);
			}
			LeaveContinueStatement(node);
		}
		
		public virtual bool EnterContinueStatement(ContinueStatement node)
		{
			return true;
		}
		
		public virtual void LeaveContinueStatement(ContinueStatement node)
		{
		}
		
		public virtual void OnRetryStatement(RetryStatement node)
		{			
			if (EnterRetryStatement(node))
			{		
				Switch(node.Modifier);
			}
			LeaveRetryStatement(node);
		}
		
		public virtual bool EnterRetryStatement(RetryStatement node)
		{
			return true;
		}
		
		public virtual void LeaveRetryStatement(RetryStatement node)
		{
		}
		
		public virtual void OnReturnStatement(ReturnStatement node)
		{			
			if (EnterReturnStatement(node))
			{		
				Switch(node.Expression);
				Switch(node.Modifier);
			}
			LeaveReturnStatement(node);
		}
		
		public virtual bool EnterReturnStatement(ReturnStatement node)
		{
			return true;
		}
		
		public virtual void LeaveReturnStatement(ReturnStatement node)
		{
		}
		
		public virtual void OnYieldStatement(YieldStatement node)
		{			
			if (EnterYieldStatement(node))
			{		
				Switch(node.Expression);
				Switch(node.Modifier);
			}
			LeaveYieldStatement(node);
		}
		
		public virtual bool EnterYieldStatement(YieldStatement node)
		{
			return true;
		}
		
		public virtual void LeaveYieldStatement(YieldStatement node)
		{
		}
		
		public virtual void OnRaiseStatement(RaiseStatement node)
		{			
			if (EnterRaiseStatement(node))
			{		
				Switch(node.Exception);
				Switch(node.Modifier);
			}
			LeaveRaiseStatement(node);
		}
		
		public virtual bool EnterRaiseStatement(RaiseStatement node)
		{
			return true;
		}
		
		public virtual void LeaveRaiseStatement(RaiseStatement node)
		{
		}
		
		public virtual void OnUnpackStatement(UnpackStatement node)
		{			
			if (EnterUnpackStatement(node))
			{		
				Switch(node.Declarations);
				Switch(node.Expression);
				Switch(node.Modifier);
			}
			LeaveUnpackStatement(node);
		}
		
		public virtual bool EnterUnpackStatement(UnpackStatement node)
		{
			return true;
		}
		
		public virtual void LeaveUnpackStatement(UnpackStatement node)
		{
		}
		
		public virtual void OnExpressionStatement(ExpressionStatement node)
		{			
			if (EnterExpressionStatement(node))
			{		
				Switch(node.Expression);
				Switch(node.Modifier);
			}
			LeaveExpressionStatement(node);
		}
		
		public virtual bool EnterExpressionStatement(ExpressionStatement node)
		{
			return true;
		}
		
		public virtual void LeaveExpressionStatement(ExpressionStatement node)
		{
		}
		
		public virtual void OnOmittedExpression(OmittedExpression node)
		{			
		}
		
		public virtual void OnExpressionPair(ExpressionPair node)
		{			
			if (EnterExpressionPair(node))
			{		
				Switch(node.First);
				Switch(node.Second);
			}
			LeaveExpressionPair(node);
		}
		
		public virtual bool EnterExpressionPair(ExpressionPair node)
		{
			return true;
		}
		
		public virtual void LeaveExpressionPair(ExpressionPair node)
		{
		}
		
		public virtual void OnMethodInvocationExpression(MethodInvocationExpression node)
		{			
			if (EnterMethodInvocationExpression(node))
			{		
				Switch(node.Target);
				Switch(node.Arguments);
				Switch(node.NamedArguments);
			}
			LeaveMethodInvocationExpression(node);
		}
		
		public virtual bool EnterMethodInvocationExpression(MethodInvocationExpression node)
		{
			return true;
		}
		
		public virtual void LeaveMethodInvocationExpression(MethodInvocationExpression node)
		{
		}
		
		public virtual void OnUnaryExpression(UnaryExpression node)
		{			
			if (EnterUnaryExpression(node))
			{		
				Switch(node.Operand);
			}
			LeaveUnaryExpression(node);
		}
		
		public virtual bool EnterUnaryExpression(UnaryExpression node)
		{
			return true;
		}
		
		public virtual void LeaveUnaryExpression(UnaryExpression node)
		{
		}
		
		public virtual void OnBinaryExpression(BinaryExpression node)
		{			
			if (EnterBinaryExpression(node))
			{		
				Switch(node.Left);
				Switch(node.Right);
			}
			LeaveBinaryExpression(node);
		}
		
		public virtual bool EnterBinaryExpression(BinaryExpression node)
		{
			return true;
		}
		
		public virtual void LeaveBinaryExpression(BinaryExpression node)
		{
		}
		
		public virtual void OnTernaryExpression(TernaryExpression node)
		{			
			if (EnterTernaryExpression(node))
			{		
				Switch(node.Condition);
				Switch(node.TrueExpression);
				Switch(node.FalseExpression);
			}
			LeaveTernaryExpression(node);
		}
		
		public virtual bool EnterTernaryExpression(TernaryExpression node)
		{
			return true;
		}
		
		public virtual void LeaveTernaryExpression(TernaryExpression node)
		{
		}
		
		public virtual void OnReferenceExpression(ReferenceExpression node)
		{			
		}
		
		public virtual void OnMemberReferenceExpression(MemberReferenceExpression node)
		{			
			if (EnterMemberReferenceExpression(node))
			{		
				Switch(node.Target);
			}
			LeaveMemberReferenceExpression(node);
		}
		
		public virtual bool EnterMemberReferenceExpression(MemberReferenceExpression node)
		{
			return true;
		}
		
		public virtual void LeaveMemberReferenceExpression(MemberReferenceExpression node)
		{
		}
		
		public virtual void OnLiteralExpression(LiteralExpression node)
		{			
		}
		
		public virtual void OnStringLiteralExpression(StringLiteralExpression node)
		{			
		}
		
		public virtual void OnTimeSpanLiteralExpression(TimeSpanLiteralExpression node)
		{			
		}
		
		public virtual void OnIntegerLiteralExpression(IntegerLiteralExpression node)
		{			
		}
		
		public virtual void OnNullLiteralExpression(NullLiteralExpression node)
		{			
		}
		
		public virtual void OnSelfLiteralExpression(SelfLiteralExpression node)
		{			
		}
		
		public virtual void OnSuperLiteralExpression(SuperLiteralExpression node)
		{			
		}
		
		public virtual void OnBoolLiteralExpression(BoolLiteralExpression node)
		{			
		}
		
		public virtual void OnRELiteralExpression(RELiteralExpression node)
		{			
		}
		
		public virtual void OnStringFormattingExpression(StringFormattingExpression node)
		{			
			if (EnterStringFormattingExpression(node))
			{		
				Switch(node.Arguments);
			}
			LeaveStringFormattingExpression(node);
		}
		
		public virtual bool EnterStringFormattingExpression(StringFormattingExpression node)
		{
			return true;
		}
		
		public virtual void LeaveStringFormattingExpression(StringFormattingExpression node)
		{
		}
		
		public virtual void OnHashLiteralExpression(HashLiteralExpression node)
		{			
			if (EnterHashLiteralExpression(node))
			{		
				Switch(node.Items);
			}
			LeaveHashLiteralExpression(node);
		}
		
		public virtual bool EnterHashLiteralExpression(HashLiteralExpression node)
		{
			return true;
		}
		
		public virtual void LeaveHashLiteralExpression(HashLiteralExpression node)
		{
		}
		
		public virtual void OnListLiteralExpression(ListLiteralExpression node)
		{			
			if (EnterListLiteralExpression(node))
			{		
				Switch(node.Items);
			}
			LeaveListLiteralExpression(node);
		}
		
		public virtual bool EnterListLiteralExpression(ListLiteralExpression node)
		{
			return true;
		}
		
		public virtual void LeaveListLiteralExpression(ListLiteralExpression node)
		{
		}
		
		public virtual void OnTupleLiteralExpression(TupleLiteralExpression node)
		{			
			if (EnterTupleLiteralExpression(node))
			{		
				Switch(node.Items);
			}
			LeaveTupleLiteralExpression(node);
		}
		
		public virtual bool EnterTupleLiteralExpression(TupleLiteralExpression node)
		{
			return true;
		}
		
		public virtual void LeaveTupleLiteralExpression(TupleLiteralExpression node)
		{
		}
		
		public virtual void OnListDisplayExpression(ListDisplayExpression node)
		{			
			if (EnterListDisplayExpression(node))
			{		
				Switch(node.Expression);
				Switch(node.Declarations);
				Switch(node.Iterator);
				Switch(node.Filter);
			}
			LeaveListDisplayExpression(node);
		}
		
		public virtual bool EnterListDisplayExpression(ListDisplayExpression node)
		{
			return true;
		}
		
		public virtual void LeaveListDisplayExpression(ListDisplayExpression node)
		{
		}
		
		public virtual void OnSlicingExpression(SlicingExpression node)
		{			
			if (EnterSlicingExpression(node))
			{		
				Switch(node.Target);
				Switch(node.Begin);
				Switch(node.End);
				Switch(node.Step);
			}
			LeaveSlicingExpression(node);
		}
		
		public virtual bool EnterSlicingExpression(SlicingExpression node)
		{
			return true;
		}
		
		public virtual void LeaveSlicingExpression(SlicingExpression node)
		{
		}
		
		public virtual void OnAsExpression(AsExpression node)
		{			
			if (EnterAsExpression(node))
			{		
				Switch(node.Target);
				Switch(node.Type);
			}
			LeaveAsExpression(node);
		}
		
		public virtual bool EnterAsExpression(AsExpression node)
		{
			return true;
		}
		
		public virtual void LeaveAsExpression(AsExpression node)
		{
		}
		
	}
}
