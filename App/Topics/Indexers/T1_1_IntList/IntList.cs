using System;
using System.Collections.Generic;

namespace App.Topics.Indexers.T1_1_IntList;

public class IntList
{
    private readonly List<int> _items = new();

    // Свойство Count — текущее количество элементов
    public int Count => _items.Count;

    // Индексатор
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index), $"Индекс {index} вне диапазона [0, {Count - 1}]");

            return _items[index];
        }
        set
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс не может быть отрицательным.");

            if (index == Count)
            {
                // Добавляем в конец — увеличиваем список
                _items.Add(value);
            }
            else if (index > Count)
            {
                // Нельзя "перепрыгнуть" — только последний элемент можно добавить
                throw new ArgumentOutOfRangeException(nameof(index), $"Индекс {index} превышает текущий размер ({Count}).");
            }
            else
            {
                // Заменяем существующий элемент
                _items[index] = value;
            }
        }
    }
}