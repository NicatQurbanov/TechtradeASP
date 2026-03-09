
using System.ComponentModel.Design;

namespace MyWolt
{
    public class Restaurant(string name)
    {
        public string Name { get; set; } = name;

        public MenuController MenuCtrl { get; set; } = new MenuController();
    }
}
