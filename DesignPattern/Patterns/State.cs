using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    // Durumu temsil eden State arayüzü
    public interface IState
    {
        void Handle(StateContext StateContext);
    }

    // Durumları uygulayan ConcreteState sınıfları
    public class OpenState : IState
    {
        public void Handle(StateContext StateContext)
        {
            Console.WriteLine("Lamba açıldı.");
            // Lamba ile ilgili açık durumda yapılacak işlemler
        }
    }

    public class ClosedState : IState
    {
        public void Handle(StateContext StateContext)
        {
            Console.WriteLine("Lamba kapatıldı.");
            // Lamba ile ilgili kapalı durumda yapılacak işlemler
        }
    }

    // Durumu yöneten StateContext sınıfı
    public class StateContext
    {
        /*
         12. State: State tasarım deseni, bir nesnenin durumuna bağlı olarak davranışını değiştirmesini sağlar. Bu desen, durumları nesne içerisinde ayrı sınıflar olarak temsil eder ve nesne durumu değiştikçe ilgili durum sınıfının davranışını etkinleştirir. Böylece, nesne davranışının değişmesi gerektiği durumlarda if-else veya switch-case gibi yapıların yerine daha esnek bir yaklaşım sunar.
         */
        private IState currentState;

        public StateContext()
        {
            currentState = new ClosedState(); // Varsayılan olarak kapalı durumu
        }

        public void SetState(IState state)
        {
            currentState = state;
        }

        public void Request()
        {
            currentState.Handle(this);
        }
    }

    

}
