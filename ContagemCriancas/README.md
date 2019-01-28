# CONCEITO DO PROJETO
Este projeto consiste em um sistema de presença para Evangelização Espírita. O sistema deve apresentar as seguinte funcionalidades:
* Os atributos base de uma pessoa são: Nome, Sobrenome, Data de Nascimento, Tipo (Evangelizadores, Evangelizandos ou Auxiliares)
* Cada pessoa só deve pertencer a um tipo
* Deve-se exibir a lista de Evangelizandos (Alunos)
* Deve-se exibir a lista de Evangelizadores (Professores)
* Deve-se exibir a lista de Auxiliares
* Deve ser possível editar uma pessoa
* Ao excluir uma pessoa, apenas inativar o cadastro
* Quando selecionar uma pessoa (Independentemente qual), deve-se exibir os detalhes\*
* Todas as Pessoas devem possuir fotos, que podem ser armazenadas
* Somente a última foto é mostrada
* Mas as fotos antigas ainda ficam guardadas
* As foto **Não devem ser guardadas** no banco de dados, mas sim na aplicação
* Uma turma deve ser composta por Evangelizadores, Evangelizandos e Auxiliares
* Uma turma deve possuir nome, o horário e o dia da semana de funcionamento
* A turma **deve possuir ao menos um Evangelizador e um Evangelizando**
* A turma pode possuir ou não Auxiliares
* Deve ser possível editar uma turma
* Ao excluir uma turma, apenas inativar o cadastro
* Todas as pessoas podem pertencer a mais de uma turma
* A presença é marcada por dia e por turma
* Deve-se selecionar os alunos que estavam presentes no dia (Checkbox)
* Pode-se excluir uma presença
* Datelhes da Pessoa:\* informando todos os dias em que ele estava presente
* Deve exibir um relatório no qual contém o resumo de presenças do dia
* Realizar Testes Unitários
## Para o futuro
* Criar usuário e senhas para os Evangelizadores
* Fazer o controle de acesso
# Tecnologias
* Restful
## Front-end
* Angular Js
* Bootstrap
* Jquery
## Back-end
* AspNet Mvc Framework
* Entity Framework
## Banco de Dados
* Oracle
