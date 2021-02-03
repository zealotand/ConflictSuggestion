using System;
using System.Collections.Generic;
using System.Text;

namespace ConflictSuggestion
{
    interface IConfSolu
    {
        //不确定，可随时修改
        public void solve(PrioCont self,PrioCont other);
    }

    class ToLargerPriority:IConfSolu
    {
        private ToLargerPriority() { }

        public void solve(PrioCont self, PrioCont other) { }
    }

    class ToSpecificPrioCont:IConfSolu
    {
        private int target_id;


        public ToSpecificPrioCont(int _targetID) { }

        public void solve(PrioCont self, PrioCont other) { }
    }
}
