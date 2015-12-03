# Proejto (Parte 1)

O projeto consiste na elaboração de um pequeno CRUD para o gerenciamento de pedidos online. Nessa primeira parte,
os alunos deverão criar as classes básicas do pedido e também de autenticação via login usando todos os conceitos 
vistos até a aula 4.

A Figura a seguir ilustra a arquitetura preliminar utilizada para essa atividade


<p align="center">
  <img width="700" src="https://github.com/aceiro/curso_dot_net_2015/blob/master/imgs/DiagramaComponente_Geral.png" alt="Screenshot"/>
</p>


<p align="center">
  <img width="500" src="https://github.com/aceiro/curso_dot_net_2015/blob/master/imgs/DiagramaClasse_Geral.png" alt="Screenshot"/>
</p>


Como ainda não aprendemos sobre banco de dados (*Entity Framework*), vamos criar tanto a validação do usuário 
quanto a lista de pedidos na sessão usando a ideia de **mock** com lista **in-memory on the fly** 

Para o desenvolvimento deste projetos os seguintes requisitos devem ser satisfeitos:
- Campos do pedido devem ser obrigatórios
- O campo ID do pedido deve ser do tipo auto-incremento
- A lista de pedidos deve ser armazenada na sessão
- Os logins devem ser armazenos em uma lista estática para recuperação via lambda
- Os usuários devem estar logados para ter acesso ao controle de pedidos (o acesso não pode ser feito via url caso o usuário não esteja logado)
- Usar as figuras para implementação