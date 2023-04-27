using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console124.Entities.Enums;

namespace Console124.Entities;

internal class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString(){
        return  Id + " , " + Moment + " , " + Status + " ";
    }

}
