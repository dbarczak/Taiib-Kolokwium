

using KolokwiumDB.DTOs;
using KolokwiumDB.Models;

namespace KolokwiumDB.Services
{
    public class KeyboardService : IKeyboardService
    {
        readonly List<Keyboard> keyboards = new()
        {
            new Keyboard { ID = 1, Model = "Acer", Rodzaj = 0 },
            new Keyboard { ID = 2, Model = "Sony", Rodzaj = (Rodzaj)3 },
            new Keyboard { ID = 3, Model = "Samsung", Rodzaj = (Rodzaj)1 },
            new Keyboard { ID = 4, Model = "Key", Rodzaj = (Rodzaj)2 },
            new Keyboard { ID = 5, Model = "Acer", Rodzaj = (Rodzaj) 2 }
        };
        public void AddKeyboard(KeyboardRequest keyboardRequest)
        {
            int id = keyboards.Max(x => x.ID);
            keyboards.Add(new Keyboard
            {
                ID = id + 1,
                Model = keyboardRequest.Model,
                Rodzaj = (Rodzaj)keyboardRequest.Rodzaj
            });
        }

        public void DeleteKeyboard(int id)
        {
            var keyboard = keyboards.Find(m=> m.ID == id);
            if(keyboard != null)
            {
                keyboards.Remove(keyboard);
            }
        }

        public IEnumerable<KeyboardResponse> GetKeyboards()
        {
            return keyboards.Select(k => new KeyboardResponse
            {
                ID = k.ID,
                Model = k.Model,
                Rodzaj = k.Rodzaj
            });
        }

    }
}
