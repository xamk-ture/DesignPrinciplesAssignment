using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{

    //Refactor this code to by using KISS principle to make it more readable and maintainable
    public class GradeEvaluator
    {
        public string Evaluate(int score)
        {
            string grade;
            if (score >= 0)
            {
                if (score < 50)
                {
                    grade = "F";
                }
                else
                {
                    if (score < 60)
                    {
                        grade = "D";
                    }
                    else
                    {
                        if (score < 70)
                        {
                            grade = "C";
                        }
                        else
                        {
                            if (score < 80)
                            {
                                grade = "B";
                            }
                            else
                            {
                                if (score <= 100)
                                {
                                    grade = "A";
                                }
                                else
                                {
                                    grade = "Invalid";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                grade = "Invalid";
            }
            return grade;
        }
    }
}
