using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    //Função para o botão iniciar
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Fase1");
    }
    
    //Função para o botão Sair
    public void SairdoJogo()
    {
    Application.Quit();
        Debug.Log("Saiu do Jogo");
    }

}