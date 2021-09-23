import styled from 'styled-components'

export const Button = styled.button`
  display: flex;
  background: transparent;
  text-align: center;
  border-radius: 10%;
  border: 1px solid ${props => props.theme.colors.primary};
`;
