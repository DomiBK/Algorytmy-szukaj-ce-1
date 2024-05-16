# Algorytmy-szukaj-ce-1

Wyszukiwanie liniowe (ang. linear search), zwane również sekwencyjnym (ang. sequential search) polega na przeglądaniu kolejnych elementów zbioru Z. Jeśli przeglądany element posiada odpowiednie własności (np. jest liczbą o poszukiwanej wartości), to zwracamy jego pozycję w  zbiorze i kończymy. W przeciwnym razie kontynuujemy poszukiwania aż do przejrzenia wszystkich pozostałych elementów zbioru Z.

W przypadku pesymistycznym, gdy poszukiwanego elementu nie ma w zbiorze lub też znajduje się on na samym końcu zbioru, algorytm musi wykonać n obiegów pętli sprawdzającej poszczególne elementy. Wynika z tego, iż pesymistyczna klasa złożoności obliczeniowej jest równa O(n), czyli jest liniowa – stąd pochodzi nazwa metody wyszukującej.

Wyszukiwanie liniowe z wartownikiem. Wartownikiem jest dodany na końcu zbioru element równy poszukiwanemu. Dzięki niemu uzyskujemy zawsze pewność znalezienia poszukiwanego elementu w zbiorze. Jeśli jest to wartownik, to elementu poszukiwanego w zbiorze nie ma i zwracamy pozycję -1. Jeśli nie jest to wartownik, to znaleźliśmy poszukiwany element w zbiorze i zwracamy jego pozycję i.

Waszym zadaniem jest utworzenie tablicy liczb losowych z rozmiarem 100
oraz utworzenie powyższych algorytmów.

Na cel:
Chcąc realizować algorytmy grafowe, będziemy zmuszeni wprowadzać różne grafy do pamięci komputera. Istnieje bardzo prosty sposób realizacji tego zadania i jest on następujący:
Na początku podajemy dwie liczby n – ilość wierzchołków oraz m –  ilość krawędzi. Następnie wprowadzamy m par liczb a i b, które definiują kolejne krawędzie grafu, gdzie a to wierzchołek startowy, a b wierzchołek końcowy (dla grafu nieskierowanego kolejność tych wierzchołków nie ma znaczenia). Umówmy się dodatkowo, że wierzchołki w grafie posiadają numery od 0 do n - 1. Kolejność numeracji wierzchołków nie ma znaczenia. Dla porządku krawędzie również będą numerowane od 0 do m - 1. Dzięki tej umowie uprości się tworzenie struktur.
Utwórz graf o ośmiu krawędziach i dziewięciu wierzchołkach.
