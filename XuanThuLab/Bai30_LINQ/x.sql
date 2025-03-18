CREATE OR REPLACE FUNCTION TAI_CHINH_PC()
RETURN VARCHAR2
AS
BEGIN
  RETURN '1=1';
-- Cho phép xem toàn bộ dữ liệu
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY
(
    object_schema   => 'HR',
    object_name     => 'PHANCONG',
    policy_name     => 'TAI_CHINH_PC_SELECT',
    function_schema => 'HR',
    policy_function => 'TAI_CHINH_PC',
    statement_types => 'SELECT'
  );
END;
/