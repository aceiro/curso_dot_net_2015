# Exercícios da aula 3

Aqui você vai encontrar os principais exercícios realizados na *Aula 3*. Em especial, aqui você tem:
- **WebApplication_Exemplo1**

Nesse exemplo, você vai interagir com uma página MVC e conhecer os principais conceitos do Framework Asp.NET MVC.
Observe atentamente o **Controller** e **View** em especial como foram criados os relacionamentos e a estrutura de pastas do template gerado pelo Visual Studio. Observe que o **Controller** contém a declaração para os tipos básicos de **Actions** que são: `ActionResult`, `PartialViewResult` e `RedirectResult`.

Além disso, observe os arquivos relativos a `View` que são `Index.cshtml` e `ExercisePartial.cshtml` onde são declarados o uso de `Helpers` do Asp.NET como por exemplo:
`@Html.Partial("ExercisePartial")
<p> @Html.ActionLink("Voltar", "Redirect") </p>`

- **WebApplication_Exemplo2**

Além do Controller  e View nesse exemplo será possível interagir com o **Model** nesse caso, observe atentamente o uso do modelo `SomaViewModel` e a forma como acionado por Injeção de Dependencia (DI) do Asp.NET com o uso da linguagem demarcação server-side [Razor](http://www.w3schools.com/aspnet/razor_intro.asp). 

> O código desse exercício resolve o problema de renderização do `@EditorFor()`
> nesse caso, foi trocado de `@EditorFor()` para `@DisplayFor()`

- **WebApplication_Exemplo3**

Aqui é apresentado um template para a implementação de uma **Calculadora** com as operações básicas. Para isso siga os passos, sugeridos nos arquivos de **CalculadoraController.cs** e **Index.cshtml**
