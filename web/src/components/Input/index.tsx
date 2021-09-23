import React from 'react'
import Head from 'next/head'
import Link from 'next/link'
import { faChevronLeft } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

import { Container, MainInput } from './styles'

interface InputProps  {
  id?: string;
  labelText: string;
  onChange: (string) => void;
}

const Input: React.FC<InputProps> = ({id, labelText, onChange}) => {
  return (
    <Container>
      <label htmlFor={id}>{labelText}</label>
      <MainInput id={id} onChange={(e) => onChange(e.target.value)} />
    </Container>
  )
}

export default Input
