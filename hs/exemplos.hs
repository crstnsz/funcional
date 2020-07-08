fat 0 = 1
fat n = n * fat (n - 1)

pot _ 0 = 1
pot a e = a * pot a (e - 1)

mdc a b | a == b    = a
        | a > b     = mdc (a - b) b
        | otherwise = mdc (b - a) a

menor (x:xs) = if x < menor xs then x else menor xs