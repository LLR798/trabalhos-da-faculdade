var jogador,
  vencedor = null
var jogadorSelecionado = document.getElementById('jogador-selecionado')
var vencedorSelecionado = document.getElementById('vencedor-selecionado')

mudarJogador('X')

function escolhercasa(id) {
  if (vencedor !== null) {
    return
  }

  var casa = document.getElementById(id)
  if (casa.innerHTML !== '-') {
    return
  }

  casa.innerHTML = jogador
  casa.style.color = '#000'

  if (jogador === 'X') {
    jogador = 'O'
  } else {
    jogador = 'X'
  }

  mudarJogador(jogador)
  checaVencedor()
}

function mudarJogador(valor) {
  jogador = valor
  jogadorSelecionado.innerHTML = jogador
}

function checaVencedor() {
  var casa1 = document.getElementById(1)
  var casa2 = document.getElementById(2)
  var casa3 = document.getElementById(3)
  var casa4 = document.getElementById(4)
  var casa5 = document.getElementById(5)
  var casa6 = document.getElementById(6)
  var casa7 = document.getElementById(7)
  var casa8 = document.getElementById(8)
  var casa9 = document.getElementById(9)

  if (checaSequencia(casa1, casa2, casa3)) {
    mudarCorcasa(casa1, casa2, casa3)
    mudarVencedor(casa1)

    return
  }

  if (checaSequencia(casa4, casa5, casa6)) {
    mudarCorcasa(casa4, casa5, casa6)
    mudarVencedor(casa4)
    return
  }

  if (checaSequencia(casa7, casa8, casa9)) {
    mudarCorcasa(casa7, casa8, casa9)
    mudarVencedor(casa7)
    return
  }

  if (checaSequencia(casa1, casa4, casa7)) {
    mudarCorcasa(casa1, casa4, casa7)
    mudarVencedor(casa1)
    return
  }

  if (checaSequencia(casa2, casa5, casa8)) {
    mudarCorcasa(casa2, casa5, casa8)
    mudarVencedor(casa2)
    return
  }

  if (checaSequencia(casa3, casa6, casa9)) {
    mudarCorcasa(casa3, casa6, casa9)
    mudarVencedor(casa3)
    return
  }

  if (checaSequencia(casa1, casa5, casa9)) {
    mudarCorcasa(casa1, casa5, casa9)
    mudarVencedor(casa1)
    return
  }

  if (checaSequencia(casa3, casa5, casa7)) {
    mudarCorcasa(casa3, casa5, casa7)
    mudarVencedor(casa3)
  }
}

function mudarVencedor(casa) {
  vencedor = casa.innerHTML
  vencedorSelecionado.innerHTML = vencedor
}

function mudarCorcasa(casa1, casa2, casa3) {
  casa1.style.background = '#0f0'
  casa2.style.background = '#0f0'
  casa3.style.background = '#0f0'
}

function checaSequencia(casa1, casa2, casa3) {
  var eigual = false

  if (
    casa1.innerHTML !== '-' &&
    casa1.innerHTML === casa2.innerHTML &&
    casa2.innerHTML === casa3.innerHTML
  ) {
    eigual = true
  }

  return eigual
}

function reiniciar() {
  vencedor = null
  vencedorSelecionado.innerHTML = ''

  for (var i = 1; i <= 9; i++) {
    var casa = document.getElementById(i)

    casa.style.background = '#eee'
    casa.style.color = '#eee'
    casa.innerHTML = '-'
  }
  mudarJogador('X')
}
