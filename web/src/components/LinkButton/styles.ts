import styled from 'styled-components'

export const Container = styled.div`
  display: flex;
`;

export const RoundButton = styled.button`
  border: 1px solid ${props => props.theme.colors.primary};
  border-radius: 20px;
  padding: 8px 40px;
  background: transparent;
  color: ${props => props.theme.colors.text};
  font-size: 1.2rem;

  cursor: pointer;


`;
