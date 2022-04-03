using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name,Boolean isWeighted):base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;

        }
    }
}
