using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Activities;
using System.ComponentModel;

namespace ListActivities
{
    public class GetItem : CodeActivity
    {
        //in and out params

        [Category("Input")]
        public InArgument<List<Object>> Container { get; set; }

        [Category("Input")]
        public InArgument<int> Index { get; set; }

        [Category("Output")]
        public OutArgument<Object> Item { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            List<Object> l = Container.Get(context);
            int index = Index.Get(context);
            Item.Set(context, l.ElementAt(index));
        }

    }

    public class InsertToList : CodeActivity
    {
        [Category("Input/Output")]
        public InOutArgument<List<Object>> Container { get; set; }

        [Category("Input")]
        public InArgument<int> Index { get; set; }

        [Category("Input")]
        public InArgument<Object> Item { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            List<Object> l = Container.Get(context);
            int index = Index.Get(context);
            Object item = Item.Get(context);
            l.Insert(index, item);
        }
    }

}
