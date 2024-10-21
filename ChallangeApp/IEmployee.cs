namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        char Sex { get; }

        int Age { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(string grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
