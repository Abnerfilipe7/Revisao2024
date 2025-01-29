# Gerador de Senha

## Descrição

Este é um simples **gerador de senhas** em C# que permite ao usuário configurar a senha de acordo com suas preferências. O usuário pode escolher a quantidade de dígitos da senha e se deseja incluir números, símbolos, letras maiúsculas ou minúsculas.

### Funcionalidades:
- **Escolha do número de dígitos**: O usuário pode definir a quantidade de caracteres para a senha.
- **Inclusão de caracteres personalizados**:
  - Números
  - Símbolos
  - Letras maiúsculas
  - Letras minúsculas
- **Validação de entrada**: O sistema valida se as respostas para cada escolha são "S" (Sim) ou "N" (Não).
- **Salvamento da senha gerada**: A senha gerada é salva automaticamente em um arquivo de backup chamado `bkp.txt`.

## Como Usar

### Compilação e Execução:
1. Abra o código no Visual Studio ou em outro IDE que suporte C#.
2. Compile e execute o programa.

### Interação com o Usuário:
1. O programa irá solicitar que você insira o número de dígitos desejado para a senha.
2. Em seguida, ele fará perguntas sobre se você quer incluir números, símbolos, letras maiúsculas ou minúsculas na senha. Para cada uma dessas perguntas, você deve responder com "S" (Sim) ou "N" (Não).

### Senha Gerada:
- Após fornecer todas as informações, o programa gerará a senha de acordo com as opções selecionadas.
- A senha gerada será exibida na tela e também será salva no arquivo `bkp.txt` no diretório onde o programa foi executado.

## Exemplo de Execução


                          GERADOR DE SENHA

         Qual a quantidade de dígitos que você deseja?
10


               Incluir números S/N?
S


               Incluir símbolos S/N?
N


              Incluir letras maiúsculas S/N?
S



              Incluir letras minúsculas S/N?
S


              Senha gerada: G7gE4Lk1B3


A senha gerada será salva no arquivo `bkp.txt` no mesmo diretório onde o programa está executando.

## Arquivo de Backup
O arquivo `bkp.txt` é criado no diretório onde o programa foi executado e contém a senha gerada para que o usuário possa acessá-la posteriormente.

## Requisitos
- .NET SDK (C#)
- Editor de código como Visual Studio ou Visual Studio Code (recomendado)

## Contribuição

Sinta-se à vontade para fazer melhorias ou corrigir problemas no código. Caso deseje contribuir, basta seguir as diretrizes de pull request para sugestões ou melhorias.

#
