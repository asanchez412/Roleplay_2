// Se establece la interfase AttackItems para poder trabajar en conjunto
// todos los items que solo presentan un valor de ataque.
// Se podría haber hecho que una única interfase que englobara a todos
// los items definiendo un attack value y defense value para todos
// pero decidimos que no dado que tendríamos que hacer que
// objetos ofensivos devuelvan 0 en defensa y viceversa para los defensivos.
// Creemos que es más prolijo diferenciarlos de acuerdo a sus posibilidades.

// Agregar las interfases que implementan tipos genéricos, nos permitió equipar  
// y desequipar items que comparten el mismo tipo genérico
// de manera más fácil y ordenada.

public interface IAttackItems
{
    int AttackValue();
}