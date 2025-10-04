using System;
using System.Collections.Generic;

namespace App.Topics.Indexers.T1_2_KeyValueStore;

public class KeyValueStore
{
    private readonly Dictionary<int, string> _byId = new();
    private readonly Dictionary<string, string> _byKey = new();

    // ���������� �� int id
    public string this[int id]
    {
        get
        {
            if (!_byId.TryGetValue(id, out string value))
                throw new KeyNotFoundException($"ID {id} �� ������.");

            return value;
        }
        set
        {
            _byId[id] = value; // ���� ���� � ��������, ���� ��� � ���������
        }
    }

    // ���������� �� string key
    public string this[string key]
    {
        get
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "���� �� ����� ���� null.");

            if (!_byKey.TryGetValue(key, out string value))
                throw new KeyNotFoundException($"���� '{key}' �� ������.");

            return value;
        }
        set
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "���� �� ����� ���� null.");

            _byKey[key] = value; // ���� ���� � ��������, ���� ��� � ���������
        }
    }
}
