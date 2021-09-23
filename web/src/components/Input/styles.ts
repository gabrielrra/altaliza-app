import styled from 'styled-components'

export const Container = styled.div`
  display: flex;
  flex-direction: column;
  padding: 20px 0;

  align-items: flex-start;
`
export const MainInput = styled.input`
  border: 1px solid ${props => props.theme.colors.primary};
  border-radius: 4px;
  padding: 4px;
  background: transparent;
  color: ${props => props.theme.colors.text};
  margin-top: 8px;
`
