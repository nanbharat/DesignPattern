using Design_Pattern.Factory.Builder.ConcreateClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Factory.Builder.IBuilder
{
   public interface ISystemBuilder
    {
        void AddMemory(string memory);
        void AddSize(string size);

        void AddMouse(string mouse);
        void AddKeyBoard(string keyboard);

        void AddTouchScreen(string enabled);
        ComputerSystem GetSystem();


    }
}
