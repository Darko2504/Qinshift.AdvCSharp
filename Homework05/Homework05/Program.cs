

using Homework05.Models;

Teacher teacher = new Teacher{Name = "John", Age = 32, Email = "johnbest@gmail.com", Subject = "C#"};

Student student1 = new Student { Name = "Alice", Age = 20, Email = "alice@gmail.com", Subject = "C#" };
Student student2 = new Student { Name = "Bob", Age = 21, Email = "bob@gmail.com", Subject = "C#" };
Student student3 = new Student { Name = "Charlie", Age = 22, Email = "charlie@gmail.com", Subject = "C#" };


teacher.Subscribe(student1);
teacher.Subscribe(student2);
teacher.Subscribe(student3);

teacher.SendNotification();


teacher.Unsubscribe(student1);
teacher.Unsubscribe(student2);

teacher.SendNotification();

