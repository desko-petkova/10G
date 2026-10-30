using Event_Management_System.Application;
using EventManagement.Application;

using EventManagement.Infrastructure;

namespace EventManagement
{
    class Program
    {
        static void Main()
        {
            IEventRepository repo = new FileEventRepository();
            //EventService service = new EventService(repo);
          //  EventUI ui = new EventUI(service);

          //  ui.Run();
        }
    }
}
