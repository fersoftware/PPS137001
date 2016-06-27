# PPS137001
Abra o Visual Studio.
Crie um namespace chamado PPS1xxxxx, sendo xxxxx o seu número de RA.

Na classe Program:

Escreva o código em C# do método Main, que solicita que o usuário digite o valor de número máximos de produtos maxProd que serão cadastrados no sistema. Esse valor deverá ser um número maior ou igual a 4 e menor ou igual a 15.
Depois, o Main, deverá criar:
- o vetor Produto, de string, com maxProd posições
- a matriz Precos, de float, com maxProd linhas e 3 colunas, uma coluna para o preço de cada mês (março, abril, maio)
- o vetor Media, com 3 posições

Solicite que o usuário digite os nomes dos produtos até preencher todo o vetor Produto.

Solicite que o usuário digite, para cada produto cadastrado, os 3 preços de cada mês, que devem ser inseridos na matriz Precos. Cada linha da matriz Precos conterá os preços de um produto.

Chame o método CalculaMedia, passando a matriz Precos e o vetor Media. Esse método deverá calcular a média dos preços de cada mês e colocar a média no vetor Media. Os preços do mês de março estão na coluna zero da matriz. A média dos preços do mês de março deverá ser colocada na posição zero do vetor Media e assim sucessivamente.

Exiba todos os dados, em forma de tabela, apresentando na primeira coluna os nomes dos produtos, na segunda coluna, os preços do mês de março, na terceira coluna, os preços do mês de abril e assim sucessivamente. Não se esqueça de exibir os títulos das colunas.

Chame o método IndiceMenor, passando o vetor Media. Esse método devolverá o índice de onde se encontra a menor média no vetor Media.
O Main deverá exibir de qual mês é a menor média e o valor da menor média.

- Escreva os códigos dos métodos conforme descrito no enunciado.
