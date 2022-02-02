using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Interpreter
    {
    }
}
/*
Паттерн Интерпретатор (Interpreter) определяет представление грамматики для заданного языка 
и интерпретатор предложений этого языка. Как правило, данный шаблон проектирования применяется
для часто повторяющихся операций.

Хотя паттерн требует понимания теории формальных языков и грамматик, на самом деле он не так сложен
в понимании.

    class Client
    {
        void Main()
        {
            Context context = new Context();
 
            var expression = new NonterminalExpression();
            expression.Interpret(context);
 
        }
    }
 
    class Context
    {
    }
 
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
 
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
        }
    }
 
    class NonterminalExpression : AbstractExpression
    {
        AbstractExpression expression1;
        AbstractExpression expression2;
        public override void Interpret(Context context)
        {
             
        }
    }

AbstractExpression: определяет интерфейс выражения, объявляет метод Interpret()

TerminalExpression: терминальное выражение, реализует метод Interpret() для терминальных символов грамматики.
Для каждого символа грамматики создается свой объект TerminalExpression

NonterminalExpression: нетерминальное выражение, представляет правило грамматики.
Для каждого отдельного правила грамматики создается свой объект NonterminalExpression.

Context: содержит общую для интерпретатора информацию. Может использоваться объектами терминальных
и нетерминальных выражений для сохранения состояния операций и последующего доступа к сохраненному состоянию

Client: строит предложения языка с данной грамматикой в виде абстрактного синтаксического дерева,
узлами которого являются объекты TerminalExpression и NonterminalExpression
*/
