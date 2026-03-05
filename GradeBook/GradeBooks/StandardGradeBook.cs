using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        // Konstruktor przyjmuje tylko nazwę, ale do bazy przekazuje nazwę i typ Standard
        public StandardGradeBook(string name) : base(name, GradeBookType.Standard)
        {
            Type = GradeBookType.Standard;
        }
    }
}