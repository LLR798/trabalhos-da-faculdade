# Assessment:
Assessment para concluir o primeiro bloco do semestre de Fundamentos em C#.

## Desafio:

Implemente um programa semelhante a um sistema de tarifas bancárias. Esse programa deve ler um arquivo existente contendo dados financeiros de vários clientes. O seu programa deve também gerar um arquivo para cada cliente contendo o total do saldo (em reais) e o total da tarifa. Siga os requisitos abaixo:

### Padrão do arquivo:

Formato do arquivo: CPF | Nome | Conta Corrente | Conta Internacional | Conta Cripto
Exemplo de um arquivo abaixo:

69814034045 | Julio Guimaraes | 500,50 | 150,05 | 115,50

82479274039 | Lucca Nicassio | 700,50 | 250,05 | 215,50

44182620089 | Geovanni Fedalto | 800,50 | 350,05 | 315,50


## Requisitos:
- O banco oferece apenas três tipos de produto (conta corrente, conta internacional e conta cripto);
  Obtenha do arquivo já existente, os dados de cada cliente;
- O saldo de conta corrente no arquivo existente é armazenado em reais;
- O saldo de conta internacional no arquivo existente é armazenado em dólar;
- O saldo de conta cripto no arquivo existente é armazenado em dólar;
- O saldo em conta corrente e conta internacional devem ser tarifados em 1,5% e 2.5% respectivamente;
- O saldo em conta cripto não é tarifado;
- Calcule o somatório dos saldos de cada tipo de conta (em real) para cada cliente;
- Calcule o somatório das tarifas de cada tipo de conta para cada cliente;
- Gere um arquivo para cada cliente, cujo nome do arquivo deve ser o número do CPF do cliente;
- O arquivo do cliente (item anterior) deve conter em uma única linha o somatório dos saldos das contas do cliente e o somatório das tarifas das contas do cliente, delimitado pelo caracter pipe “|”.
- Para arquivo de cliente gerado, exiba uma mensagem para o usuário, sinalizando que um arquivo foi gerado para um determinado número de cpf (exemplo: Arquivo gerado para o cpf 99999999999).

## Requisitos técnicos:
- Considere todos os requisitos técnicos documentados no TP3, adaptando para o contexto de leitura e escrita de arquivos (change request);
- Crie uma classe para representar os dados (cinco informações em cada linha) do arquivo;
- Crie um método para calcular o somatório dos saldos e das tarifas de cada cliente, na classe que representa o sistema de tarifas. Este método deve receber como parâmetros: uma coleção com os dados do arquivo e um delegate (personalizado ou Action) de callback;
- Crie um evento para notificar a conclusão do somatório dos saldos e das tarifas de cada cliente, na classe que representa o sistema de tarifas;
- No programa principal, faça a leitura do arquivo, criando uma coleção com os dados do arquivo;
- No programa principal, instancie um objeto da classe que representa o sistema de tarifas, usando o construtor padrão;
- No programa principal, crie um método para escrever os dados do arquivo de cada cliente. Este método deve ser compatível (assinatura do método) com o evento que notifica o somatório de saldo e tarifa. Ainda no programa principal, assine o evento do objeto que representa o sistema de tarifas;
- No programa principal, acione o método para calcular o somatório dos saldos e das tarifas dos clientes, fornecendo como parâmetros: uma coleção com os dados do arquivo e um método (callback) para exibir no console uma mensagem de cada arquivo gerado;
- O método responsável por calcular o somatório de saldo e tarifa de cada cliente deve, ao final de cada somatório, disparar o método callback (parâmetro: cpf) e o evento (parâmetro: cpf, saldo, tarifa).
- Utilize o recurso de lambda expression em alguma parte do seu programa;