//DON'T TOUCH!!!!!
namespace Model.Abstract {
	interface IOperator {
        /// <summary>
        /// �������� ���������
        /// </summary>
        /// <param name="src">���������� �������</param>
        /// <param name="reapply�ount">����� ��������</param>
        /// <returns></returns>
		byte[,] Transform(byte[,] src, int reapply�ount);
	}
}
