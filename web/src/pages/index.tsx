import React from 'react'

import Head from 'next/head'
import Link from 'next/link'

import { Container } from '../styles/pages/Home'
import Button from '../components/Button'

const Home: React.FC = () => {
  return (
    <Container>
      <Head>
        <title>Altaliza</title>
      </Head>

      <h1>Altaliza</h1>
      <p>Aluguel de carros, simplificado</p>

      <hr />
      <Link href="register">
        <Button text="Criar novo usuário"/>
      </Link>
      <Link href="login">
        <Button text="Já tenho um usuário" />
      </Link>

    </Container>
  )
}

export default Home
