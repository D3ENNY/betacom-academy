const tsvc = {
    casualString: () => {
        const str = ['buongiorno','good morning', 'bonjuour']
        const index = Math.floor(Math.random() * str.length)
        return str[index]
    }
}

export default tsvc