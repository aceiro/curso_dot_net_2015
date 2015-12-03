# Proejto (Parte 1)

O projeto consiste na elabora��o de um pequeno CRUD para o gerenciamento de pedidos online. Nessa primeira parte,
os alunos dever�o criar as classes b�sicas do pedido e tamb�m de autentica��o via login usando todos os conceitos 
vistos at� a aula 4.

A Figura a seguir ilustra a arquitetura preliminar utilizada para essa atividade


<p align="center">
  <img width="700" src="https://github.com/aceiro/curso_dot_net_2015/blob/master/imgs/DiagramaComponente_Geral.png" alt="Screenshot"/>
</p>


<p align="center">
  <img width="500" src="https://github.com/aceiro/curso_dot_net_2015/blob/master/imgs/DiagramaClasse_Geral.png" alt="Screenshot"/>
</p>


Como ainda n�o aprendemos sobre banco de dados (*Entity Framework*), vamos criar tanto a valida��o do usu�rio 
quanto a lista de pedidos na sess�o usando a ideia de **mock** com lista **in-memory on the fly** 

Para o desenvolvimento deste projetos os seguintes requisitos devem ser satisfeitos:
- Campos do pedido devem ser obrigat�rios
- O campo ID do pedido deve ser do tipo auto-incremento
- A lista de pedidos deve ser armazenada na sess�o
- Os logins devem ser armazenos em uma lista est�tica para recupera��o via lambda
- Os usu�rios devem estar logados para ter acesso ao controle de pedidos (o acesso n�o pode ser feito via url caso o usu�rio n�o esteja logado)
- Usar as figuras para implementa��o