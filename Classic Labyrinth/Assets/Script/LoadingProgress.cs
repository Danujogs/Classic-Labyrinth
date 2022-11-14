using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingProgress : MonoBehaviour
{
    [SerializeField] Image Image;

    private void Start()
    {
        StartCoroutine(Progress());
    }

    IEnumerator Progress()
    {
        Image.fillAmount = 0;
        yield return new WaitForSeconds(1);

        var asyncOp = SceneManager.LoadSceneAsync(SceneLoader.SceneToLoad);

        while (asyncOp.isDone == false)
        {
            Image.fillAmount = asyncOp.progress;
            yield return null;
        }
    }
}
