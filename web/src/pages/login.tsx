import React, { useEffect, useState } from 'react'
import Head from 'next/head'

import { Container, FormContainer } from '../styles/pages/Login'

import Header from '../components/Header'
import Input from '../components/Input'
import Button from '../components/Button'
import { api } from '../services/api'
import { useRouter } from 'next/router'

const Login: React.FC = () => {
  const [user, setUser] = useState('')
  const [loadingUser, setLoadingUser] = useState(false)
  const [infoText, setInfoText] = useState('')

  const router = useRouter()

  function loginUser() {
    api
      .get('personagem', { params: { username: user } })
      .then(({ data }) => {
        if (data.length > 0) {
          window.localStorage.setItem('user', user)
          router.push('main')
        } else {
          setInfoText('Usuário não cadastrado')
        }
      })
      .catch(e => console.log(e))
  }
  return (
    <>
      <Header />
      <Container>
        <FormContainer>
          <Input
            id="user"
            labelText="Usuário"
            onChange={value => setUser(value)}
          />
          <span>{infoText}</span>
        </FormContainer>
        <Button
          text="Login"
          onClick={() => loginUser()}
        ></Button>
      </Container>
    </>
  )
}

export default Login
