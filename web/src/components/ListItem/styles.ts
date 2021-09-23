import styled from 'styled-components'

export const Container = styled.div`
  display: flex;
  border-radius: 20px;
  flex-direction: column;
  padding: 20px 0;
  background: #cacaca;
  align-items: flex-start;
  color: black;
  align-items: center;
  margin-bottom: 20px;

  img {
    width: 400px;
  }
`
export const MainInput = styled.input`
  border: 1px solid ${props => props.theme.colors.primary};
  padding: 8px;
  background: transparent;
  color: ${props => props.theme.colors.text};
  margin-top: 8px;
`
