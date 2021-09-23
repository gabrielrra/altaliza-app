import React from 'react'
import Head from 'next/head'
import Link from 'next/link'
import { faChevronLeft } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

import { useRouter } from 'next/router'

import { Container } from './styles'

const Header: React.FC = () => {
  const router = useRouter()
  return (
    <Container>
      <a onClick={() =>  router.back()} title="Voltar">
        <FontAwesomeIcon icon={faChevronLeft} size="2x"></FontAwesomeIcon>
      </a>
    </Container>
  )
}

export default Header
