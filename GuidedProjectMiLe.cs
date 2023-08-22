using System;

// initialize variables - graded assignments 
int examAssignments = 5;


int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int [] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score \t\tOverall Grade\t\tExtra Credit\n");


foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew") 
        studentScores = andrewScores;
    

    else if (currentStudent == "Emma") 
        studentScores = emmaScores;
    

    else if (currentStudent == "Logan") 
        studentScores = loganScores;
    
    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;
     
        
    decimal sumAssignmentScoresTotal = 0;
    decimal sumAssignmentScores = 0;
    decimal currentStudentGradeTotal = 0m;
    decimal extraPoints = 0;
    int gradedAssignments = 0;
    int extraCredits = 0;
    int numberOfAditionalCredits = 0;
    foreach (int grades in studentScores)
    {   
        gradedAssignments ++;
        if (gradedAssignments <= examAssignments) {
            sumAssignmentScoresTotal += grades;
            sumAssignmentScores += grades;
        }
        else {
            extraPoints += (decimal) grades/10;
            sumAssignmentScoresTotal += (decimal) grades / 10;
            extraCredits += grades;
            numberOfAditionalCredits++;
        }
    }

    extraPoints /= (decimal) examAssignments;
    extraCredits /= numberOfAditionalCredits;
    sumAssignmentScores /= (decimal) examAssignments;
    currentStudentGradeTotal = (decimal)sumAssignmentScoresTotal / examAssignments;


    if (currentStudentGradeTotal > 96)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGradeTotal > 92)
        currentStudentLetterGrade = "A";

    else if (currentStudentGradeTotal > 91)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGradeTotal > 88)
        currentStudentLetterGrade = "B+";
    
    else if (currentStudentGradeTotal > 82)
        currentStudentLetterGrade = "B";    
    
    else if (currentStudentGradeTotal > 79)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGradeTotal > 76)
        currentStudentLetterGrade = "C+";
    
    else if (currentStudentGradeTotal > 72)
        currentStudentLetterGrade = "C";

    else if (currentStudentGradeTotal > 69)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGradeTotal > 66)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGradeTotal > 62)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGradeTotal > 59)
        currentStudentLetterGrade = "D";
    
    else
        currentStudentLetterGrade = "F";
    Console.WriteLine($"{currentStudent}\t\t{sumAssignmentScores}\t\t\t{currentStudentGradeTotal}\t{currentStudentLetterGrade}\t\t{extraCredits}\t({extraPoints}pts)");
    
    
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

