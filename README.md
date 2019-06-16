# Trabalho de Teste de Software
## Trabalhando com Nunit

> **Instituição:** Pontifícia Universidade Católica  
> **Curso:** Sistemas de Informação  
> **Disciplina:** Fundamentos de Teste de Software  
> **Professor:** Henrique Batista  

Foi de desenvolvido um teste de software simples com o apoio da ferramenta NUnit.
O Objetivo foi praticar os conceitos aprendidos ao longo da disciplina.

Para executar os testes é importante saber:
- O programa testado está armazenado na pasta *`Bank`*.
- Este programa possui na pasta *`Bank/Bank/bin/Debug`* um arquivo chamado *`Bank.dll`*
- O arquivo *Bank.dll* É usado pelo teste, ele é importado nas referências da pasta de teste.
- O teste está armazenado na pasta *`UnitTestLib`*
- Dentro da pasta *`UnitTestLib/UnitTestLib/bin/Debug`* possui a biblioteca de testes *`UnitTestLib.dll`*
- Devemos usar *`UnitTestLib.dll`* em algum console ou GUI do Nunit para que os testes possam ser executados.
- Antes é crucial verificar se o arquivo *`nunit.framework.dll`* e *`Bank.dll`* estão na pasta de Debug do projeto, para que sua execução ocorra corretamente.
