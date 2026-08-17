export function startTypingAnimation(elementId, text, speed) {
    const element = document.getElementById(elementId);
    if (!element || !text) return;
    
    element.textContent = '';
    element.style.visibility = 'visible';
    let index = 0;

    function typeChar() {
        if (index < text.length) {
            element.textContent += text.charAt(index);
            index++;
            setTimeout(typeChar, speed || 70);
        }
    }

    typeChar();
}
