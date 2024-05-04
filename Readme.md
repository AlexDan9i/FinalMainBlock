## Урок 1. Контрольная работа

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной   
   содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть 
   так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## Задача: 
   Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Р
## Примеры:
   [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
   [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
   [“Russia”, “Denmark”, “Kazan”] → []


 ## Описание работы программы:
  1.  Программа предлагает ввести размерность массива, предусмотрены 2 варианта, одномерный и двумерный массива строк. Если введена другая разменость, программа завершается с ошибкой "Некорректный ввод. Размерность не поддерживается прокраммой."
  2. Далее предлагается ввести элементы массива строк. Для одномерного массива элементы разделяются пробелом, Для двумерного, строки массива разделяются символом ";", а элементы внутри строк разделяются символом ",".
  3. В одномерном массиве вводиться строка элеменнов, программа проходит по каждому элементу в этой строке и проверят его на соответствие условию. Если длина элемента меньше или равна 3 символам, элемент добавляется в новый массив.  
  4. В двумерном массиве, введенная строка разбивается на строки массива. Затем каждая строка разбивается на элементы, чтобы сформировать двумерный массив строк. Фильтрация массива: Проходя по каждой строке и каждому элементу в этой строке, программа проверяет длину элемента. Если длина элемента меньше или равна 3 символам, элемент добавляется в новый массив.
  5. Создание нового двумерного массива: Программа создает новый массив с размерами, учитывающими только отфильтрованные элементы.
  6. Заполнение нового массива: Происходит заполнение нового массива отфильтрованными элементами из исходного массива.
  7. Вывод нового массива: На экран выводится итоговый массив из отфильрованных элементов.
