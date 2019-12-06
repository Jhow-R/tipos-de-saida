# Tipos De Saída

Ref: A palavra-chave ref é usado para passar um argumento como uma referência. Isto significa que quando o valor do referido parâmetro é mudado no método, ele se reflete no método de chamada. Um argumento que é passado usando uma palavra-chave ref deve ser inicializado no método de chamada antes de ser passado para o método chamado.

Out: A palavra-chave out também é usada para passar um argumento como a palavra-chave ref, mas o argumento pode ser passado sem atribuir qualquer valor a ela. Um argumento que é passado usando uma palavra-chave out deve ser inicializado no método antes de retornar a chamada do mesmo.

In: Em C# 7.2 existe o in que permite um parâmetro ser recebido como referência igual ao ref, porém é garantido que este valor não será alterado, pelo menos pela referência (se tentar modificar usará uma técnica de COW). Ele é útil em casos que exige muita performance e não deseja fazer uma alocação no heap pressionando o GC. Pense nele como um ref readonly.
