using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    class Routine
    {

        public List<Employee> ParseUsers() //чтение данных пользователей
        {
            List<Employee> users = new List<Employee>();

            string[] lines = File.ReadAllLines("../../../data/пользователи.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 3)
                {
                    string username = parts[0];
                    string password = parts[1];
                    int id = int.Parse(parts[2]);
                    users.Add(new Employee(username, password, id));
                }
            }

            return users;
        }
        public List<Components> ParseComponents()//парсинг деталей
        {
            var file = File.ReadAllLines("../../../data/детали.txt");
            List<Components> ret = new List<Components>();
            for (int i = 0; i < file.Length; i++)
            {
                string[] m = file[i].Split(" ");
                try
                {
                    ret.Add(new Components(int.Parse(m[0]), m[1], int.Parse(m[2]), int.Parse(m[3]), int.Parse(m[4]), int.Parse(m[5]), int.Parse(m[6])));
                }
                catch
                {
                    MessageBox.Show("Неверный формат деталей, обратитесь к сис. админу!", "Ошибка");
                }
            }
            return ret;
        }

        public List<Orders> ParseOrders()//парсинг деталей
        {
            var file = File.ReadAllLines("../../../data/заказы.txt");
            List<Orders> ret = new List<Orders>();
            for (int i = 0; i < file.Length; i++)
            {
                string[] m = file[i].Split(" ");
                try
                {
                    ret.Add(new Orders(int.Parse(m[0]), int.Parse(m[1]), int.Parse(m[2]), int.Parse(m[3]), decimal.Parse(m[4])));
                }
                catch
                {
                    MessageBox.Show("Неверный формат заказов, обратитесь к сис. админу!", "Ошибка");
                }
            }
            return ret;
        }
        public List<Storage> ParseStorage()//парсинг склада
        {
            var file = File.ReadAllLines("../../../data/склад.txt");
            List<Storage> ret = new List<Storage>();
            for (int i = 0; i < file.Length; i++)
            {
                string[] m = file[i].Split(" ");
                try
                {
                    ret.Add(new Storage(int.Parse(m[0]), int.Parse(m[1]), decimal.Parse(m[2])));
                }
                catch
                {
                    MessageBox.Show("Неверный формат склада, обратитесь к сис. админу!", "Ошибка");
                }
            }
            return ret;
        }
        public void OpenLoginForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginForm)
                {
                    form.Show();
                    break;
                }
            }

        }
        public IEnumerable<object> GetComponentsTable()// таблица деталей
        {
                var col = from t in ParseComponents()
                          orderby t.id
                          select new
                          {
                              ID = t.id,
                              Название = t.name,
                              Класс = t.class1,
                              Подкласс = t.subclass,
                              Группа = t.@group,
                              Подгруппа = t.subgroup,
                              Вид = t.vid,
                          };
                return col;
        }
        public IEnumerable<object> GetStorageTable()// таблица склада
        {
            var col = from t in ParseStorage()
                      select new
                      {
                          ID = t.id,
                          Количество = t.count,
                          Стоимость = t.price,
                      };
            return col;
        }
        public IEnumerable<object> GetUserTable()// таблица пользователей
        {
            var col = from t in ParseUsers()
                      select new
                      {
                          Имя = t.name,
                          Должность = t.occupation == 1 ? "Продавец" :
                          t.occupation == 2 ? "Менеджер" :
                          t.occupation == 3 ? "Администратор":
                          ""
                      };
            return col;
        }
        public IEnumerable<object> GetOrderTable() // таблица заказов
        {
            var col = from t in ParseOrders()
                      select new
                      {
                          ID = t.ID,
                          Деталь = t.component,
                          Количество =t.count,
                          Статус = t.status == 1 ? "На складе" :
                          t.status == 2 ? "В пути" :
                          t.status == 3 ? "Ждет выдачи" :
                          t.status == 4 ? "Выдано" :
                          "",
                          Цена =t.price
                      };
            return col;
        }

    }
}
