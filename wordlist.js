let wordlist=[];

function addWord(){
    const searchInput=document.getElementById('searchin');
    const translationIn=document.getElementById('translationin');
    const word=searchInput.value.trim();
    const translation=translationIn.value.trim();

    if(word!=='' && translation!==''){
        const newWord={word,translation};
        wordlist=push(newWord);

        searchInput.value='';
        translationIn.value='';
        displayWordList();
    }
}

function displayWordList(){
    const wordlistElement=document.getElementById('wordlist');
   wordlistElement.innerHTML='';
   for(let i=0;i<wordlist.length;i++){
    const listItem=document.createElement('li');
    listItem.textContent=`${wordlist[i].word}-${wordlist.translation}`;
    wordlistElement.appendChild(listItem);
   }

}

const addButton=document.getElementById('addButton');
addButton.addEventListener('click',addWord);