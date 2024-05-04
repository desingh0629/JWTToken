using JWTTokenAuthenicationProj.Helpers;

namespace JWTTokenAuthenicationProj.Interfce
{
    public interface ICommonService
    {
        string GetTokent(UserHelperModel user);
    }
}
