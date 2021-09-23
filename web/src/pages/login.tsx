import React, { useEffect, useState } from 'react'
import Head from 'next/head'

import { Container, FormContainer } from '../styles/pages/Login'

import Header from '../components/Header'
import Input from '../components/Input'
import Button from '../components/Button'
import { api } from '../services/api'
import { useRouter } from 'next/router'

const Home: React.FC = () => {
  const [user, setUser] = useState('')
  const [loadingUser, setLoadingUser] = useState(false)
  const [isOk, setIsOk] = useState(false)
  const [infoText, setInfoText] = useState(
    'Digite um nome para verificar a disponibilidade'
  )

  const router = useRouter()

  useEffect(() => {
    if (user !== '') {
      setInfoText('Verificando disponibilidade...')
      setLoadingUser(true)
      let waitingTimer = setTimeout(() => {
        api
          .get('personagem', { params: { username: user } })
          .then(({ data }) => {
            setLoadingUser(false)
            if (data.length === 0) {
              setInfoText('Usuário disponível!')
              setIsOk(true)
            } else {
              setInfoText('Usuário não disponível. Digite outro.')
              setIsOk(false)
            }
          })
          .catch(e => console.error(e))
      }, 1000)
      return () => {
        clearTimeout(waitingTimer)
      }
    } else {
      setInfoText('Digite um nome para verificar a disponibilidade')
      setLoadingUser(false)
    }
  }, [user])

  function saveNewUser() {
    api.post('personagem', { nome: user, carteira: 0 }).then(({ data }) => {
      router.push('main')
    })
  }
  return (
    <>
      <Header />
      <Container>
        <h3>Digite o nome de usuário que deseja usar</h3>
        <FormContainer>
          <Input
            id="user"
            labelText="Usuário"
            onChange={value => setUser(value)}
          />
          <span>{infoText}</span>
        </FormContainer>
        <Button
          text="Continuar"
          disabled={!isOk}
          onClick={() => saveNewUser()}
        ></Button>
      </Container>
    </>
  )
}

export default Home
