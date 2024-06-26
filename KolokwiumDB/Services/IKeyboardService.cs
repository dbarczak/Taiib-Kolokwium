using KolokwiumDB.DTOs;

namespace KolokwiumDB.Services
{
    public interface IKeyboardService
    {
        public void AddKeyboard(KeyboardRequest keyboardRequest);
        public void DeleteKeyboard(int id);
        public IEnumerable<KeyboardResponse> GetKeyboards();
    }
}
