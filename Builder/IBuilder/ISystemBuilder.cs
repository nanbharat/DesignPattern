using Design_Pattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Builder.IBuilder
{
  public interface ISystemBuilder
    {

        void AddMemory(string memory);
        void AddDrive(string drive);

        ComputerSystem GetSystem();


    }
}
