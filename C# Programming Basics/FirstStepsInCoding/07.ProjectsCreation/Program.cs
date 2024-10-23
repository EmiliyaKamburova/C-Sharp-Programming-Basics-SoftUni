string architectName =  Console.ReadLine();
int numProjects = int.Parse(Console.ReadLine());
int hoursPerProject = 3;

int hoursAllprojects = numProjects * hoursPerProject;

Console.WriteLine($"The architect {architectName} will need {hoursAllprojects} hours to complete {numProjects} project/s.");
