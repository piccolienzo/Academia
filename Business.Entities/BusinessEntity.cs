using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified,
        }

        private int id;
        private States state;
       
        public States State { get { return state; } set { state = value; } }
        public int ID { get { return id; }  set {id = value; } }

        public BusinessEntity()
        {
            this.State = States.New;
        }
      
   }

}
