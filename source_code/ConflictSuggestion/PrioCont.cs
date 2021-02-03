using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConflictSuggestion
{
    enum EConfSolu
    {
        TO_LARGER_PRIORITY,
        TO_SPECIFIC_PRICONT,
    }
    class PrioCont
    {
        private int id;
        private IConfSolu default_solution;
        private Dictionary<int, IConfSolu> specific_solution_set;

        public void setDefaultSolution(EConfSolu _solution_type, int? _target_id) { }
        public void setDefaultSolution(IConfSolu _solution) { }

        public bool addSpecificSolution(int _other_id, EConfSolu _solution_type, int? _target_id) { return true; }
        public bool addSpecificSolution(int _other_id, IConfSolu _solution) { return true; }
        public bool rmvSpecificSolution(int _other_id) { return true; }
        public bool chkSpecificSolution(int _other_id) { return true; }
    }
}
