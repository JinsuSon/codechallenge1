int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// 학생 이름
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// 콘솔에 보고서 제목 쓰기
Console.WriteLine("Student\t\tGrade\n");

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

    // 점수가 매겨진 과목들의 합계를 초기화
    int sumAssignmentScores = 0;

    // 계산 된 평균 점수와 추가학점의 초기화
    decimal currentStudentGrade = 0;

    // 과제 숫자 카운터 초기화
    int gradeAssignments = 0;

    foreach (int score in studentScores)
    {
        gradeAssignments += 1;

        if (gradeAssignments <= examAssignments)
            // 시험 점수를 합계에 추가
            sumAssignmentScores += score;
        else
            // 크레딧 점수를 합계에 추가 - 보너스 점수는 시험 점수의 10%
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal) sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
       currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
       currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
       currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

