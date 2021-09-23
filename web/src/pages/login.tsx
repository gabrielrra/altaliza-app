import React, { useEffect, useState } from 'react'
import Head from 'next/head'

import { Container, FormContainer } from '../styles/pages/Login'

import Header from '../components/Header'
import Input from '../components/Input'
import LinkButton from '../components/LinkButton'

const Home: React.FC = () => {
  const [user, setUser] = useState('');
  useEffect(() => {
    console.log(user)
  }, [user]);
  return (
    <>
      <Header />
      <Container>
        <h3>Digite o nome de usuário que deseja usar</h3>
        <FormContainer>
          <Input id="user" labelText="Usuário" onChange={(value) => setUser(value)} />

        </FormContainer>
          <LinkButton href="main" text="Continuar"></LinkButton>
      </Container>
    </>
  )
}

export default Home
