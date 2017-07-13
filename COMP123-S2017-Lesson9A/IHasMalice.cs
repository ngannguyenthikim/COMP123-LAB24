using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Nguyen Thi Kim Ngan
* Date: July 13, 2017
* Description: This is the Interface that defines a Malice Property 
* must be implemented in any class that subscribes to it.
* Version: 0.1- Created IHasMalice Interface
*/
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is IHasMalice Interface
    /// </summary>
    public interface IHasMalice
    {
        // PUBLIC PROPERTIES
        int Malice { get; set; }
    }
}