using Newtonsoft.Json;

namespace StudentMeter
{
    public static class SaveLoad
    {
        private static readonly string _saveFileStudentsPath = Path.Combine(Application.StartupPath, "save.json");

        public static void Save()
        {
            //Bug guard.
            if (StudentMethods.Students.Count == 0)
            {
                return;
            }

            //Converts dictionary members to json data.
            string jsonData = JsonConvert.SerializeObject(StudentMethods.Students);

            //Writes json data to the file.
            using (StreamWriter writer = File.CreateText(_saveFileStudentsPath))
            {
                writer.Write(jsonData);
            }
        }

        public static void Load()
        {
            //If there is no save file, generates a new one.
            if (!File.Exists(_saveFileStudentsPath))
            {
                File.Create(_saveFileStudentsPath);
                return;
            }

            using (StreamReader reader = new(_saveFileStudentsPath))
            {
                //Reads the save file.
                string jsonData = reader.ReadToEnd();

                //Converts the data which is in json to list.
                List<Student>? listOfStudents = JsonConvert.DeserializeObject<List<Student>>(jsonData);

                //Null check
                if (listOfStudents == null)
                {
                    return;
                }

                //Adds to all data to list.
                StudentMethods.Students.AddRange(listOfStudents);
            }
        }
    }
}