using System;
using System.Collections.Generic;

namespace App.Topics.Indexers.T1_2_KeyValueStore;

public class KeyValueStore
{
    private readonly Dictionary<int, string> _byId = new();
    private readonly Dictionary<string, string> _byKey = new();

    // »ндексатор по int id
    public string this[int id]
    {
        get
        {
            if (!_byId.TryGetValue(id, out string value))
                throw new KeyNotFoundException($"ID {id} не найден.");

            return value;
        }
        set
        {
            _byId[id] = value; // ≈сли есть Ч замен€ем, если нет Ч добавл€ем
        }
    }

    // »ндексатор по string key
    public string this[string key]
    {
        get
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), " люч не может быть null.");

            if (!_byKey.TryGetValue(key, out string value))
                throw new KeyNotFoundException($" люч '{key}' не найден.");

            return value;
        }
        set
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), " люч не может быть null.");

            _byKey[key] = value; // ≈сли есть Ч замен€ем, если нет Ч добавл€ем
        }
    }
}
